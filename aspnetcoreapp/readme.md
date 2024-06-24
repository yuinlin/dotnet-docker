cd aspnetcoreapp


docker build -t yuinlin/aspnetcoreapp .   
docker run -d -p 5189:80 --name yltest yuinlin/aspnetcoreapp

curl http://localhost:5189/showrequest

# optional push to dockerhub; need to be signed in
docker push yuinlin/aspnetcoreapp
