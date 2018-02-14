'use strict';
var http = require('http');
var express = require('express');
var app = express();

app.get("/", function (req, res) {
    
    res.send("Title: EJS");
    
});

var server = http.createServer(app);
server.listen(1414);