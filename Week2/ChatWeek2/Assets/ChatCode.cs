using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using WebSocketSharp;

public class ChatCode : MonoBehaviour
{
    public InputField ip, port,inputusersend;
    public GameObject concectAtive,chatAtive;
    string S_ip, S_port, S_portandip,returnmessage;
    private WebSocket websocket;
    bool checkusersend = false;
    public Text sendmess, gotmessage;
    // Start is called before the first frame update
    void Start()
    {        

    }
    // Update is called once per frame
    void Update()
    {       

    }
    public void connectserver()
    {
        S_ip = ip.text;
        S_port = port.text;
        S_portandip = ("ws://" + S_ip + ":" + S_port + "/");
        websocket = new WebSocket(S_portandip);
        websocket.OnMessage += OnMessage;
        websocket.Connect();
        concectAtive.SetActive(false);
        chatAtive.SetActive(true);
    }
    public void OnMessage(object sender, MessageEventArgs messageEventArgs)
    {
        Debug.Log(messageEventArgs.Data);
        returnmessage = messageEventArgs.Data;
        resaltUser();
    }
    public void sendmessage()
    {
        websocket.Send(inputusersend.text);
        sendmess.text += ("\r\n" + inputusersend.text);
        inputusersend.text = ("");
        checkusersend = true;
    }
    public void resaltUser()
    {
        switch(checkusersend)
        {
            case true:
                gotmessage.text += ("\r\n");
                checkusersend = false;
                break;
            case false:
                gotmessage.text += ("\r\n" + returnmessage);
                sendmess.text += ("\r\n");
                break;
        }
    }
}
