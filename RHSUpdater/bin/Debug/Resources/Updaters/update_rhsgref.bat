del /s /f "%~dp0addons\*.build"
del /s /f "%~dp0addons\*.bisign"
wget -m -nH --cut-dirs=2 --retry-connrefused --timeout=30 ftp://ftp.rhsmods.org/beta/rhsgref/