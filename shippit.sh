dotnet publish ./Effluvium/Effluvium.vbproj -o ./pub-linux -c Release --sc -r linux-x64
dotnet publish ./Effluvium/Effluvium.vbproj -o ./pub-windows -c Release --sc -r win-x64
butler push pub-windows thegrumpygamedev/effluvium:windows
butler push pub-linux thegrumpygamedev/effluvium:linux
git add -A
git commit -m "shipped it!"