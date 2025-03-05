app_name='testconfig'

sudo docker stop $app_name
sudo docker remove $app_name
sudo docker image remove $app_name
sudo docker build -t $app_name .
sudo docker run -it --name $app_name -p 5046:8080 $app_name -e "TestConfigValue=Docker Environment"