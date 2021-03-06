/**
 * Autogenerated by Thrift Compiler (0.8.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using Thrift.Protocol;
using Thrift.Transport;
namespace com.think.messages
{

  [Serializable]
  public partial class HaremOperateListResponse : TBase
  {
    private List<HaremOperateResponse> _messageList;

    public List<HaremOperateResponse> MessageList
    {
      get
      {
        return _messageList;
      }
      set
      {
        __isset.messageList = true;
        this._messageList = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool messageList;
    }

    public HaremOperateListResponse() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.List) {
              {
                MessageList = new List<HaremOperateResponse>();
                TList _list420 = iprot.ReadListBegin();
                for( int _i421 = 0; _i421 < _list420.Count; ++_i421)
                {
                  HaremOperateResponse _elem422 = new HaremOperateResponse();
                  _elem422 = new HaremOperateResponse();
                  _elem422.Read(iprot);
                  MessageList.Add(_elem422);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("HaremOperateListResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (MessageList != null && __isset.messageList) {
        field.Name = "messageList";
        field.Type = TType.List;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, MessageList.Count));
          foreach (HaremOperateResponse _iter423 in MessageList)
          {
            _iter423.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("HaremOperateListResponse(");
      sb.Append("MessageList: ");
      sb.Append(MessageList);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
