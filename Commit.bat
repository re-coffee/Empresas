set /P Atualizacao=Descreva a atualizacao:
git add .
git commit -m "%Atualizacao%"
git push
timeout 50