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
  public partial class UIHintListResponse : TBase
  {
    private List<UIHintResponse> _uiHintList;
    private int _award_id;
    private int _uiID;

    public List<UIHintResponse> UiHintList
    {
      get
      {
        return _uiHintList;
      }
      set
      {
        __isset.uiHintList = true;
        this._uiHintList = value;
      }
    }

    public int Award_id
    {
      get
      {
        return _award_id;
      }
      set
      {
        __isset.award_id = true;
        this._award_id = value;
      }
    }

    public int UiID
    {
      get
      {
        return _uiID;
      }
      set
      {
        __isset.uiID = true;
        this._uiID = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool uiHintList;
      public bool award_id;
      public bool uiID;
    }

    public UIHintListResponse() {
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
                UiHintList = new List<UIHintResponse>();
                TList _list234 = iprot.ReadListBegin();
                for( int _i235 = 0; _i235 < _list234.Count; ++_i235)
                {
                  UIHintResponse _elem236 = new UIHintResponse();
                  _elem236 = new UIHintResponse();
                  _elem236.Read(iprot);
                  UiHintList.Add(_elem236);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              Award_id = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I32) {
              UiID = iprot.ReadI32();
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
      TStruct struc = new TStruct("UIHintListResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (UiHintList != null && __isset.uiHintList) {
        field.Name = "uiHintList";
        field.Type = TType.List;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, UiHintList.Count));
          foreach (UIHintResponse _iter237 in UiHintList)
          {
            _iter237.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (__isset.award_id) {
        field.Name = "award_id";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Award_id);
        oprot.WriteFieldEnd();
      }
      if (__isset.uiID) {
        field.Name = "uiID";
        field.Type = TType.I32;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(UiID);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("UIHintListResponse(");
      sb.Append("UiHintList: ");
      sb.Append(UiHintList);
      sb.Append(",Award_id: ");
      sb.Append(Award_id);
      sb.Append(",UiID: ");
      sb.Append(UiID);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
