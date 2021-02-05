var wsocket = require("ws")
var wsocketServer = new wsocket.Server({port:30001},()=>{
    console.log("runing server")
})
var wslist = []
wsocketServer.on("connection",(ws,rq)=>{
    console.log("client connected")
    wslist.push(ws)
    ws.on("message",(data)=>{
        portnew = data
        console.log("send form client : "+portnew)
        Boardcast(data)
    })
    ws.on("close",()=>{
        wslist = arrayremove(wslist, ws)
        console.log("client disconnected")
    })
})
function arrayremove(arr,value)
{
    return arr.filter((element)=>{
        return element != value;
    })
}
function Boardcast(data)
{
    for(var i = 0; i < wslist.length; i++)
    {
        wslist[i].send(data)
    }
}