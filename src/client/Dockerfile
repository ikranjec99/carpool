# build env
FROM node:15.10.0-alpine3.11 as build
WORKDIR /app

COPY package.json /app/package.json

#RUN npm install --silent && npm install react-scripts@4.0.3 -g --silent
RUN npm install --legacy-peer-deps && npm install react-scripts@4.0.3 -g 

# Start Nginx server
CMD [ "npm", "start"]