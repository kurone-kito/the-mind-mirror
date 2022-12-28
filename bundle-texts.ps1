Set-StrictMode -Version Latest

$AtlasSourceFile = './Assets/TheMindMirror/Resources/Texts/AtlasSource.txt'

Get-ChildItem -Path './TextResources', './CHANGELOG.txt' `
  | ForEach-Object { (Get-Content -Path $_.FullName) -join ' ' } `
  | ForEach-Object { $_ -replace ' +', ' ' } `
  | Set-Content -Path $AtlasSourceFile
