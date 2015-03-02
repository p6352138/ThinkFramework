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
  public partial class PlayerStrategyListResponse : TBase
  {
    private List<PlayerStrategyResponse> _listStrategy;
    private int _strategy_id;
    private int _gold_ratio;
    private int _token_ratio;

    public List<PlayerStrategyResponse> ListStrategy
    {
      get
      {
        return _listStrategy;
      }
      set
      {
        __isset.listStrategy = true;
        this._listStrategy = value;
      }
    }

    public int Strategy_id
    {
      get
      {
        return _strategy_id;
      }
      set
      {
        __isset.strategy_id = true;
        this._strategy_id = value;
      }
    }

    public int Gold_ratio
    {
      get
      {
        return _gold_ratio;
      }
      set
      {
        __isset.gold_ratio = true;
        this._gold_ratio = value;
      }
    }

    public int Token_ratio
    {
      get
      {
        return _token_ratio;
      }
      set
      {
        __isset.token_ratio = true;
        this._token_ratio = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool listStrategy;
      public bool strategy_id;
      public bool gold_ratio;
      public bool token_ratio;
    }

    public PlayerStrategyListResponse() {
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
                ListStrategy = new List<PlayerStrategyResponse>();
                TList _list504 = iprot.ReadListBegin();
                for( int _i505 = 0; _i505 < _list504.Count; ++_i505)
                {
                  PlayerStrategyResponse _elem506 = new PlayerStrategyResponse();
                  _elem506 = new PlayerStrategyResponse();
                  _elem506.Read(iprot);
                  ListStrategy.Add(_elem506);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              Strategy_id = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I32) {
              Gold_ratio = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.I32) {
              Token_ratio = iprot.ReadI32();
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
      TStruct struc = new TStruct("PlayerStrategyListResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (ListStrategy != null && __isset.listStrategy) {
        field.Name = "listStrategy";
        field.Type = TType.List;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, ListStrategy.Count));
          foreach (PlayerStrategyResponse _iter507 in ListStrategy)
          {
            _iter507.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (__isset.strategy_id) {
        field.Name = "strategy_id";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Strategy_id);
        oprot.WriteFieldEnd();
      }
      if (__isset.gold_ratio) {
        field.Name = "gold_ratio";
        field.Type = TType.I32;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Gold_ratio);
        oprot.WriteFieldEnd();
      }
      if (__isset.token_ratio) {
        field.Name = "token_ratio";
        field.Type = TType.I32;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Token_ratio);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("PlayerStrategyListResponse(");
      sb.Append("ListStrategy: ");
      sb.Append(ListStrategy);
      sb.Append(",Strategy_id: ");
      sb.Append(Strategy_id);
      sb.Append(",Gold_ratio: ");
      sb.Append(Gold_ratio);
      sb.Append(",Token_ratio: ");
      sb.Append(Token_ratio);
      sb.Append(")");
      return sb.ToString();
    }

  }

}