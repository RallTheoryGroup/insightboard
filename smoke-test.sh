# Verify the candidate in folder $1, then consume it
set -euo pipefail
cd "$1"
sha256sum -c package.sha256
dotnet new console -o smoke
cat > smoke/Program.cs <<'EOF'
var p = new InsightBoard.Core.Calculator().Percentage(50, 200);
Console.WriteLine($"Percentage(50, 200) = {p}");
return p == 25 ? 0 : 1;
EOF
dotnet add smoke package InsightBoard.Core --prerelease -s "$PWD"
dotnet run --project smoke