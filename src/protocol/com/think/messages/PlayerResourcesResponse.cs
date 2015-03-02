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
  public partial class PlayerResourcesResponse : TBase
  {
    private int _food;
    private int _prestige;
    private int _officerId;
    private int _loyalty;
    private int _forces;
    private int _exploit;
    private int _maxFood;
    private int _maxForces;

    public int Food
    {
      get
      {
        return _food;
      }
      set
      {
        __isset.food = true;
        this._food = value;
      }
    }

    public int Prestige
    {
      get
      {
        return _prestige;
      }
      set
      {
        __isset.prestige = true;
        this._prestige = value;
      }
    }

    public int OfficerId
    {
      get
      {
        return _officerId;
      }
      set
      {
        __isset.officerId = true;
        this._officerId = value;
      }
    }

    public int Loyalty
    {
      get
      {
        return _loyalty;
      }
      set
      {
        __isset.loyalty = true;
        this._loyalty = value;
      }
    }

    public int Forces
    {
      get
      {
        return _forces;
      }
      set
      {
        __isset.forces = true;
        this._forces = value;
      }
    }

    public int Exploit
    {
      get
      {
        return _exploit;
      }
      set
      {
        __isset.exploit = true;
        this._exploit = value;
      }
    }

    public int MaxFood
    {
      get
      {
        return _maxFood;
      }
      set
      {
        __isset.maxFood = true;
        this._maxFood = value;
      }
    }

    public int MaxForces
    {
      get
      {
        return _maxForces;
      }
      set
      {
        __isset.maxForces = true;
        this._maxForces = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool food;
      public bool prestige;
      public bool officerId;
      public bool loyalty;
      public bool forces;
      public bool exploit;
      public bool maxFood;
      public bool maxForces;
    }

    public PlayerResourcesResponse() {
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
              Food = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              Prestige = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I32) {
              OfficerId = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.I32) {
              Loyalty = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.I32) {
              Forces = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.I32) {
              Exploit = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.I32) {
              MaxFood = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.I32) {
              MaxForces = iprot.ReadI32();
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
      TStruct struc = new TStruct("PlayerResourcesResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.food) {
        field.Name = "food";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Food);
        oprot.WriteFieldEnd();
      }
      if (__isset.prestige) {
        field.Name = "prestige";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Prestige);
        oprot.WriteFieldEnd();
      }
      if (__isset.officerId) {
        field.Name = "officerId";
        field.Type = TType.I32;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(OfficerId);
        oprot.WriteFieldEnd();
      }
      if (__isset.loyalty) {
        field.Name = "loyalty";
        field.Type = TType.I32;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Loyalty);
        oprot.WriteFieldEnd();
      }
      if (__isset.forces) {
        field.Name = "forces";
        field.Type = TType.I32;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Forces);
        oprot.WriteFieldEnd();
      }
      if (__isset.exploit) {
        field.Name = "exploit";
        field.Type = TType.I32;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Exploit);
        oprot.WriteFieldEnd();
      }
      if (__isset.maxFood) {
        field.Name = "maxFood";
        field.Type = TType.I32;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(MaxFood);
        oprot.WriteFieldEnd();
      }
      if (__isset.maxForces) {
        field.Name = "maxForces";
        field.Type = TType.I32;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(MaxForces);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("PlayerResourcesResponse(");
      sb.Append("Food: ");
      sb.Append(Food);
      sb.Append(",Prestige: ");
      sb.Append(Prestige);
      sb.Append(",OfficerId: ");
      sb.Append(OfficerId);
      sb.Append(",Loyalty: ");
      sb.Append(Loyalty);
      sb.Append(",Forces: ");
      sb.Append(Forces);
      sb.Append(",Exploit: ");
      sb.Append(Exploit);
      sb.Append(",MaxFood: ");
      sb.Append(MaxFood);
      sb.Append(",MaxForces: ");
      sb.Append(MaxForces);
      sb.Append(")");
      return sb.ToString();
    }

  }

}