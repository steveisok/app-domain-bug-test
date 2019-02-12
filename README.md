This sample will fail when run under mini (mimicking the unit test) and succeed when run against an installed mono w/ ADHost.dll installed in the gac.

For mini, I copied ADHost.dll into mcs/class/lib/net_4_x and ran from bash:

MONO_PATH="(your-mono-repo-path)/mcs/class/lib/net_4_x-macos:(your-mono-repo-path)/mcs/class/lib/net_4_x-macos/tests:.:$MONO_PATH" (your-mono-repo-path)/runtime/mono-wrapper --debug --interpreter  (path-to-this-project)/bin/Debug/ADTest.exe

To run against the installed mono, first put ADHost.dll into the gac and run 

(path-to-installed-mono)/bin/mono --debug --interpreter (path-to-this-project)/bin/Debug/ADTest.exe
