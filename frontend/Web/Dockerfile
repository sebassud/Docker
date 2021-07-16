FROM node:latest as build

WORKDIR /app
COPY package*.json ./
RUN npm install --no-optional

COPY . ./
RUN npm run prod

FROM nginx:latest
COPY ./cert /etc/ssl/certs
COPY nginx.conf /etc/nginx/conf.d/default.conf
COPY --from=build /app/dist/Web /usr/share/nginx/html

EXPOSE 80
EXPOSE 443