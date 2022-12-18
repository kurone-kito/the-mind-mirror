Set-StrictMode -Version Latest

$AtlasSourceFile = './Assets/TextMesh Pro/Resources/AtlasSource.txt'

Get-ChildItem -Path './TextResources', './CHANGELOG.txt' `
  | ForEach-Object { (Get-Content -Path $_.FullName) -join ' ' } `
  | ForEach-Object { $_ -replace ' +', ' ' } `
  | Set-Content -Path $AtlasSourceFile
