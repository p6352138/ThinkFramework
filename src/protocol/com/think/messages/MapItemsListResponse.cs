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
  public partial class MapItemsListResponse : TBase
  {
    private List<MapItemsResponse> _listItems;
    private int _image;
    private string _influence_info;

    public List<MapItemsResponse> ListItems
    {
      get
      {
        return _listItems;
      }
      set
      {
        __isset.listItems = true;
        this._listItems = value;
      }
    }

    public int Image
    {
      get
      {
        return _image;
      }
      set
      {
        __isset.image = true;
        this._image = value;
      }
    }

    public string Influence_info
    {
      get
      {
        return _influence_info;
      }
      set
      {
        __isset.influence_info = true;
        this._influence_info = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool listItems;
      public bool image;
      public bool influence_info;
    }

    public MapItemsListResponse() {
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
                ListItems = new List<MapItemsResponse>();
                TList _list398 = iprot.ReadListBegin();
                for( int _i399 = 0; _i399 < _list398.Count; ++_i399)
                {
                  MapItemsResponse _elem400 = new MapItemsResponse();
                  _elem400 = new MapItemsResponse();
                  _elem400.Read(iprot);
                  ListItems.Add(_elem400);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              Image = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.String) {
              Influence_info = iprot.ReadString();
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
      TStruct struc = new TStruct("MapItemsListResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (ListItems != null && __isset.listItems) {
        field.Name = "listItems";
        field.Type = TType.List;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, ListItems.Count));
          foreach (MapItemsResponse _iter401 in ListItems)
          {
            _iter401.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (__isset.image) {
        field.Name = "image";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Image);
        oprot.WriteFieldEnd();
      }
      if (Influence_info != null && __isset.influence_info) {
        field.Name = "influence_info";
        field.Type = TType.String;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Influence_info);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("MapItemsListResponse(");
      sb.Append("ListItems: ");
      sb.Append(ListItems);
      sb.Append(",Image: ");
      sb.Append(Image);
      sb.Append(",Influence_info: ");
      sb.Append(Influence_info);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
