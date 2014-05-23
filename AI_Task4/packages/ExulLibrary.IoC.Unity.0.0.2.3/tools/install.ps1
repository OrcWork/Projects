param($installPath, $toolsPath, $package, $project)

write-host $installPath
write-host $toolsPath

$asms = $package.AssemblyReferences | %{$_.Name -replace '.dll',''}

Add-Type -AssemblyName 'Microsoft.Build, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'

$projectCollection = [Microsoft.Build.Evaluation.ProjectCollection]::GlobalProjectCollection

$allProjects = $projectCollection.GetLoadedProjects($project.Object.Project.FullName).GetEnumerator();

if($allProjects.MoveNext())
{
    $currentProject = $allProjects.Current

    $references = @()

    foreach($Reference in $currentProject.GetItems('Reference'))
    {
        $include = $Reference.Xml.Include
        $isInPackage = false
        foreach ($packageItem in $asms)
        {
            $isInPackage = $Reference.Xml.Include -like "$packageItem*"
            if ($isInPackage)
            {
                break
            }
        }

        if ($isInPackage)
        {
            $references += $Reference
        }
    }

    foreach ($Reference in $references)
    {
        $include = $Reference.Xml.Include
        write-host $include

        $hintPath = $Reference.GetMetadataValue("HintPath")

        write-host 'Replace: ' + $hintPath

        if ($hintPath -like '*Debug*')
        {
            $path = $hintPath -replace 'Debug', '$(Configuration)'
        }

        if ($hintPath -like '*Release*')
        {
            $path = $hintPath -replace 'Release', '$(Configuration)'
        }

        write-host 'By: ' + $path

        $currentProject.RemoveItem($reference)

        $metaData = new-object "System.Collections.Generic.Dictionary``2[[System.String, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[System.String, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]"
        $metaData.Add("HintPath", $path)
        $currentProject.AddItem('Reference', $include, $metaData)
    }
}