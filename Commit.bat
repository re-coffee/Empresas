@set /P Atualizacao=What are you going to deliver? 
git add .
git commit -m "%Atualizacao%"
git push
@pause