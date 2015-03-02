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
  public partial class PlayerKnowledgeResponse : TBase
  {
    private List<KnowledgeResponse> _playerKnowledge;

    public List<KnowledgeResponse> PlayerKnowledge
    {
      get
      {
        return _playerKnowledge;
      }
      set
      {
        __isset.playerKnowledge = true;
        this._playerKnowledge = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool playerKnowledge;
    }

    public PlayerKnowledgeResponse() {
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
                PlayerKnowledge = new List<KnowledgeResponse>();
                TList _list76 = iprot.ReadListBegin();
                for( int _i77 = 0; _i77 < _list76.Count; ++_i77)
                {
                  KnowledgeResponse _elem78 = new KnowledgeResponse();
                  _elem78 = new KnowledgeResponse();
                  _elem78.Read(iprot);
                  PlayerKnowledge.Add(_elem78);
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
      TStruct struc = new TStruct("PlayerKnowledgeResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (PlayerKnowledge != null && __isset.playerKnowledge) {
        field.Name = "playerKnowledge";
        field.Type = TType.List;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, PlayerKnowledge.Count));
          foreach (KnowledgeResponse _iter79 in PlayerKnowledge)
          {
            _iter79.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("PlayerKnowledgeResponse(");
      sb.Append("PlayerKnowledge: ");
      sb.Append(PlayerKnowledge);
      sb.Append(")");
      return sb.ToString();
    }

  }

}