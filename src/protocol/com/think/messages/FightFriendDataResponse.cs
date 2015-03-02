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
  public partial class FightFriendDataResponse : TBase
  {
    private int _role_instance_id;
    private string _role_name;
    private short _category;
    private int _maxHp;
    private short _dander;
    private short _image;
    private short _icon;
    private byte _category_type;
    private byte _ordnance_type;
    private short _release_skill_dander;
    private int _star_lvl;
    private int _hp;

    public int Role_instance_id
    {
      get
      {
        return _role_instance_id;
      }
      set
      {
        __isset.role_instance_id = true;
        this._role_instance_id = value;
      }
    }

    public string Role_name
    {
      get
      {
        return _role_name;
      }
      set
      {
        __isset.role_name = true;
        this._role_name = value;
      }
    }

    public short Category
    {
      get
      {
        return _category;
      }
      set
      {
        __isset.category = true;
        this._category = value;
      }
    }

    public int MaxHp
    {
      get
      {
        return _maxHp;
      }
      set
      {
        __isset.maxHp = true;
        this._maxHp = value;
      }
    }

    public short Dander
    {
      get
      {
        return _dander;
      }
      set
      {
        __isset.dander = true;
        this._dander = value;
      }
    }

    public short Image
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

    public short Icon
    {
      get
      {
        return _icon;
      }
      set
      {
        __isset.icon = true;
        this._icon = value;
      }
    }

    public byte Category_type
    {
      get
      {
        return _category_type;
      }
      set
      {
        __isset.category_type = true;
        this._category_type = value;
      }
    }

    public byte Ordnance_type
    {
      get
      {
        return _ordnance_type;
      }
      set
      {
        __isset.ordnance_type = true;
        this._ordnance_type = value;
      }
    }

    public short Release_skill_dander
    {
      get
      {
        return _release_skill_dander;
      }
      set
      {
        __isset.release_skill_dander = true;
        this._release_skill_dander = value;
      }
    }

    public int Star_lvl
    {
      get
      {
        return _star_lvl;
      }
      set
      {
        __isset.star_lvl = true;
        this._star_lvl = value;
      }
    }

    public int Hp
    {
      get
      {
        return _hp;
      }
      set
      {
        __isset.hp = true;
        this._hp = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool role_instance_id;
      public bool role_name;
      public bool category;
      public bool maxHp;
      public bool dander;
      public bool image;
      public bool icon;
      public bool category_type;
      public bool ordnance_type;
      public bool release_skill_dander;
      public bool star_lvl;
      public bool hp;
    }

    public FightFriendDataResponse() {
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
              Role_instance_id = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              Role_name = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I16) {
              Category = iprot.ReadI16();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.I32) {
              MaxHp = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.I16) {
              Dander = iprot.ReadI16();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.I16) {
              Image = iprot.ReadI16();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.I16) {
              Icon = iprot.ReadI16();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.Byte) {
              Category_type = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 9:
            if (field.Type == TType.Byte) {
              Ordnance_type = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 10:
            if (field.Type == TType.I16) {
              Release_skill_dander = iprot.ReadI16();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 11:
            if (field.Type == TType.I32) {
              Star_lvl = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 12:
            if (field.Type == TType.I32) {
              Hp = iprot.ReadI32();
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
      TStruct struc = new TStruct("FightFriendDataResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.role_instance_id) {
        field.Name = "role_instance_id";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Role_instance_id);
        oprot.WriteFieldEnd();
      }
      if (Role_name != null && __isset.role_name) {
        field.Name = "role_name";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Role_name);
        oprot.WriteFieldEnd();
      }
      if (__isset.category) {
        field.Name = "category";
        field.Type = TType.I16;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI16(Category);
        oprot.WriteFieldEnd();
      }
      if (__isset.maxHp) {
        field.Name = "maxHp";
        field.Type = TType.I32;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(MaxHp);
        oprot.WriteFieldEnd();
      }
      if (__isset.dander) {
        field.Name = "dander";
        field.Type = TType.I16;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteI16(Dander);
        oprot.WriteFieldEnd();
      }
      if (__isset.image) {
        field.Name = "image";
        field.Type = TType.I16;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteI16(Image);
        oprot.WriteFieldEnd();
      }
      if (__isset.icon) {
        field.Name = "icon";
        field.Type = TType.I16;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        oprot.WriteI16(Icon);
        oprot.WriteFieldEnd();
      }
      if (__isset.category_type) {
        field.Name = "category_type";
        field.Type = TType.Byte;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Category_type);
        oprot.WriteFieldEnd();
      }
      if (__isset.ordnance_type) {
        field.Name = "ordnance_type";
        field.Type = TType.Byte;
        field.ID = 9;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Ordnance_type);
        oprot.WriteFieldEnd();
      }
      if (__isset.release_skill_dander) {
        field.Name = "release_skill_dander";
        field.Type = TType.I16;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteI16(Release_skill_dander);
        oprot.WriteFieldEnd();
      }
      if (__isset.star_lvl) {
        field.Name = "star_lvl";
        field.Type = TType.I32;
        field.ID = 11;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Star_lvl);
        oprot.WriteFieldEnd();
      }
      if (__isset.hp) {
        field.Name = "hp";
        field.Type = TType.I32;
        field.ID = 12;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Hp);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("FightFriendDataResponse(");
      sb.Append("Role_instance_id: ");
      sb.Append(Role_instance_id);
      sb.Append(",Role_name: ");
      sb.Append(Role_name);
      sb.Append(",Category: ");
      sb.Append(Category);
      sb.Append(",MaxHp: ");
      sb.Append(MaxHp);
      sb.Append(",Dander: ");
      sb.Append(Dander);
      sb.Append(",Image: ");
      sb.Append(Image);
      sb.Append(",Icon: ");
      sb.Append(Icon);
      sb.Append(",Category_type: ");
      sb.Append(Category_type);
      sb.Append(",Ordnance_type: ");
      sb.Append(Ordnance_type);
      sb.Append(",Release_skill_dander: ");
      sb.Append(Release_skill_dander);
      sb.Append(",Star_lvl: ");
      sb.Append(Star_lvl);
      sb.Append(",Hp: ");
      sb.Append(Hp);
      sb.Append(")");
      return sb.ToString();
    }

  }

}