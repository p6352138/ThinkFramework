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
  public partial class StarBagResponse : TBase
  {
    private int _instance_id;
    private int _user_id;
    private int _general_id;
    private int _star_id;
    private int _nums;
    private StarDetailResponse _starDetail;

    public int Instance_id
    {
      get
      {
        return _instance_id;
      }
      set
      {
        __isset.instance_id = true;
        this._instance_id = value;
      }
    }

    public int User_id
    {
      get
      {
        return _user_id;
      }
      set
      {
        __isset.user_id = true;
        this._user_id = value;
      }
    }

    public int General_id
    {
      get
      {
        return _general_id;
      }
      set
      {
        __isset.general_id = true;
        this._general_id = value;
      }
    }

    public int Star_id
    {
      get
      {
        return _star_id;
      }
      set
      {
        __isset.star_id = true;
        this._star_id = value;
      }
    }

    public int Nums
    {
      get
      {
        return _nums;
      }
      set
      {
        __isset.nums = true;
        this._nums = value;
      }
    }

    public StarDetailResponse StarDetail
    {
      get
      {
        return _starDetail;
      }
      set
      {
        __isset.starDetail = true;
        this._starDetail = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool instance_id;
      public bool user_id;
      public bool general_id;
      public bool star_id;
      public bool nums;
      public bool starDetail;
    }

    public StarBagResponse() {
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
            if (field.Type == TType.I32) {
              Instance_id = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              User_id = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I32) {
              General_id = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.I32) {
              Star_id = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.I32) {
              Nums = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.Struct) {
              StarDetail = new StarDetailResponse();
              StarDetail.Read(iprot);
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
      TStruct struc = new TStruct("StarBagResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.instance_id) {
        field.Name = "instance_id";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Instance_id);
        oprot.WriteFieldEnd();
      }
      if (__isset.user_id) {
        field.Name = "user_id";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(User_id);
        oprot.WriteFieldEnd();
      }
      if (__isset.general_id) {
        field.Name = "general_id";
        field.Type = TType.I32;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(General_id);
        oprot.WriteFieldEnd();
      }
      if (__isset.star_id) {
        field.Name = "star_id";
        field.Type = TType.I32;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Star_id);
        oprot.WriteFieldEnd();
      }
      if (__isset.nums) {
        field.Name = "nums";
        field.Type = TType.I32;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Nums);
        oprot.WriteFieldEnd();
      }
      if (StarDetail != null && __isset.starDetail) {
        field.Name = "starDetail";
        field.Type = TType.Struct;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        StarDetail.Write(oprot);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("StarBagResponse(");
      sb.Append("Instance_id: ");
      sb.Append(Instance_id);
      sb.Append(",User_id: ");
      sb.Append(User_id);
      sb.Append(",General_id: ");
      sb.Append(General_id);
      sb.Append(",Star_id: ");
      sb.Append(Star_id);
      sb.Append(",Nums: ");
      sb.Append(Nums);
      sb.Append(",StarDetail: ");
      sb.Append(StarDetail== null ? "<null>" : StarDetail.ToString());
      sb.Append(")");
      return sb.ToString();
    }

  }

}