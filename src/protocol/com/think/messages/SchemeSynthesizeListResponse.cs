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
  public partial class SchemeSynthesizeListResponse : TBase
  {
    private List<SchemeSynthesizeMaterialResponse> _schemeList;
    private string _scheme_version;
    private List<int> _player_scheme;

    public List<SchemeSynthesizeMaterialResponse> SchemeList
    {
      get
      {
        return _schemeList;
      }
      set
      {
        __isset.schemeList = true;
        this._schemeList = value;
      }
    }

    public string Scheme_version
    {
      get
      {
        return _scheme_version;
      }
      set
      {
        __isset.scheme_version = true;
        this._scheme_version = value;
      }
    }

    public List<int> Player_scheme
    {
      get
      {
        return _player_scheme;
      }
      set
      {
        __isset.player_scheme = true;
        this._player_scheme = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool schemeList;
      public bool scheme_version;
      public bool player_scheme;
    }

    public SchemeSynthesizeListResponse() {
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
                SchemeList = new List<SchemeSynthesizeMaterialResponse>();
                TList _list632 = iprot.ReadListBegin();
                for( int _i633 = 0; _i633 < _list632.Count; ++_i633)
                {
                  SchemeSynthesizeMaterialResponse _elem634 = new SchemeSynthesizeMaterialResponse();
                  _elem634 = new SchemeSynthesizeMaterialResponse();
                  _elem634.Read(iprot);
                  SchemeList.Add(_elem634);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              Scheme_version = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.List) {
              {
                Player_scheme = new List<int>();
                TList _list635 = iprot.ReadListBegin();
                for( int _i636 = 0; _i636 < _list635.Count; ++_i636)
                {
                  int _elem637 = 0;
                  _elem637 = iprot.ReadI32();
                  Player_scheme.Add(_elem637);
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
      TStruct struc = new TStruct("SchemeSynthesizeListResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (SchemeList != null && __isset.schemeList) {
        field.Name = "schemeList";
        field.Type = TType.List;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, SchemeList.Count));
          foreach (SchemeSynthesizeMaterialResponse _iter638 in SchemeList)
          {
            _iter638.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (Scheme_version != null && __isset.scheme_version) {
        field.Name = "scheme_version";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Scheme_version);
        oprot.WriteFieldEnd();
      }
      if (Player_scheme != null && __isset.player_scheme) {
        field.Name = "player_scheme";
        field.Type = TType.List;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.I32, Player_scheme.Count));
          foreach (int _iter639 in Player_scheme)
          {
            oprot.WriteI32(_iter639);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("SchemeSynthesizeListResponse(");
      sb.Append("SchemeList: ");
      sb.Append(SchemeList);
      sb.Append(",Scheme_version: ");
      sb.Append(Scheme_version);
      sb.Append(",Player_scheme: ");
      sb.Append(Player_scheme);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
