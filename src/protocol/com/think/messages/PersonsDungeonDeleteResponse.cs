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
  public partial class PersonsDungeonDeleteResponse : TBase
  {
    private int _dungeon_instance_id;

    public int Dungeon_instance_id
    {
      get
      {
        return _dungeon_instance_id;
      }
      set
      {
        __isset.dungeon_instance_id = true;
        this._dungeon_instance_id = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool dungeon_instance_id;
    }

    public PersonsDungeonDeleteResponse() {
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
              Dungeon_instance_id = iprot.ReadI32();
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
      TStruct struc = new TStruct("PersonsDungeonDeleteResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.dungeon_instance_id) {
        field.Name = "dungeon_instance_id";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Dungeon_instance_id);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("PersonsDungeonDeleteResponse(");
      sb.Append("Dungeon_instance_id: ");
      sb.Append(Dungeon_instance_id);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
