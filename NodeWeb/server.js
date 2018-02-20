'use strict';
var http = require('http');
var express = require('express');
var app = express();

app.get("/", function (req, res) {
    
    res.send( "CurrencyCodeFrom: USD, CurrencyCodeTo: INR, Amount: 100,");
    
});

var server = http.createServer(app);
server.listen(1414);