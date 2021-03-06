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
  public partial class EquipmentWashResponse : TBase
  {
    private byte _resType;
    private EquipmentWashBaseDataResponse _equipmentWashBaseDataResponse;
    private EquipmentWashOpenResponse _equipmentWashOpenResponse;
    private EquipmentNormalWashResponse _equipmentNormalWashResponse;
    private EquipmentWashUpgradeResponse _equipmentWashUpgradeResponse;
    private EquipmentBatchWashResponse _equipmentBatchWashResponse;
    private EquipmentCompleteBatchWashResponse _equipmentCompleteBatchWashResponse;
    private WashStoneShopResponse _washStoneShopResponse;
    private WashStoneBuyResponse _washStoneBuyResponse;
    private InEquipmentBatchWashResponse _inEquipmentBatchWashResponse;

    public byte ResType
    {
      get
      {
        return _resType;
      }
      set
      {
        __isset.resType = true;
        this._resType = value;
      }
    }

    public EquipmentWashBaseDataResponse EquipmentWashBaseDataResponse
    {
      get
      {
        return _equipmentWashBaseDataResponse;
      }
      set
      {
        __isset.equipmentWashBaseDataResponse = true;
        this._equipmentWashBaseDataResponse = value;
      }
    }

    public EquipmentWashOpenResponse EquipmentWashOpenResponse
    {
      get
      {
        return _equipmentWashOpenResponse;
      }
      set
      {
        __isset.equipmentWashOpenResponse = true;
        this._equipmentWashOpenResponse = value;
      }
    }

    public EquipmentNormalWashResponse EquipmentNormalWashResponse
    {
      get
      {
        return _equipmentNormalWashResponse;
      }
      set
      {
        __isset.equipmentNormalWashResponse = true;
        this._equipmentNormalWashResponse = value;
      }
    }

    public EquipmentWashUpgradeResponse EquipmentWashUpgradeResponse
    {
      get
      {
        return _equipmentWashUpgradeResponse;
      }
      set
      {
        __isset.equipmentWashUpgradeResponse = true;
        this._equipmentWashUpgradeResponse = value;
      }
    }

    public EquipmentBatchWashResponse EquipmentBatchWashResponse
    {
      get
      {
        return _equipmentBatchWashResponse;
      }
      set
      {
        __isset.equipmentBatchWashResponse = true;
        this._equipmentBatchWashResponse = value;
      }
    }

    public EquipmentCompleteBatchWashResponse EquipmentCompleteBatchWashResponse
    {
      get
      {
        return _equipmentCompleteBatchWashResponse;
      }
      set
      {
        __isset.equipmentCompleteBatchWashResponse = true;
        this._equipmentCompleteBatchWashResponse = value;
      }
    }

    public WashStoneShopResponse WashStoneShopResponse
    {
      get
      {
        return _washStoneShopResponse;
      }
      set
      {
        __isset.washStoneShopResponse = true;
        this._washStoneShopResponse = value;
      }
    }

    public WashStoneBuyResponse WashStoneBuyResponse
    {
      get
      {
        return _washStoneBuyResponse;
      }
      set
      {
        __isset.washStoneBuyResponse = true;
        this._washStoneBuyResponse = value;
      }
    }

    public InEquipmentBatchWashResponse InEquipmentBatchWashResponse
    {
      get
      {
        return _inEquipmentBatchWashResponse;
      }
      set
      {
        __isset.inEquipmentBatchWashResponse = true;
        this._inEquipmentBatchWashResponse = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool resType;
      public bool equipmentWashBaseDataResponse;
      public bool equipmentWashOpenResponse;
      public bool equipmentNormalWashResponse;
      public bool equipmentWashUpgradeResponse;
      public bool equipmentBatchWashResponse;
      public bool equipmentCompleteBatchWashResponse;
      public bool washStoneShopResponse;
      public bool washStoneBuyResponse;
      public bool inEquipmentBatchWashResponse;
    }

    public EquipmentWashResponse() {
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
            if (field.Type == TType.Byte) {
              ResType = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.Struct) {
              EquipmentWashBaseDataResponse = new EquipmentWashBaseDataResponse();
              EquipmentWashBaseDataResponse.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.Struct) {
              EquipmentWashOpenResponse = new EquipmentWashOpenResponse();
              EquipmentWashOpenResponse.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.Struct) {
              EquipmentNormalWashResponse = new EquipmentNormalWashResponse();
              EquipmentNormalWashResponse.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.Struct) {
              EquipmentWashUpgradeResponse = new EquipmentWashUpgradeResponse();
              EquipmentWashUpgradeResponse.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.Struct) {
              EquipmentBatchWashResponse = new EquipmentBatchWashResponse();
              EquipmentBatchWashResponse.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.Struct) {
              EquipmentCompleteBatchWashResponse = new EquipmentCompleteBatchWashResponse();
              EquipmentCompleteBatchWashResponse.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.Struct) {
              WashStoneShopResponse = new WashStoneShopResponse();
              WashStoneShopResponse.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 9:
            if (field.Type == TType.Struct) {
              WashStoneBuyResponse = new WashStoneBuyResponse();
              WashStoneBuyResponse.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 10:
            if (field.Type == TType.Struct) {
              InEquipmentBatchWashResponse = new InEquipmentBatchWashResponse();
              InEquipmentBatchWashResponse.Read(iprot);
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
      TStruct struc = new TStruct("EquipmentWashResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.resType) {
        field.Name = "resType";
        field.Type = TType.Byte;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(ResType);
        oprot.WriteFieldEnd();
      }
      if (EquipmentWashBaseDataResponse != null && __isset.equipmentWashBaseDataResponse) {
        field.Name = "equipmentWashBaseDataResponse";
        field.Type = TType.Struct;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        EquipmentWashBaseDataResponse.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (EquipmentWashOpenResponse != null && __isset.equipmentWashOpenResponse) {
        field.Name = "equipmentWashOpenResponse";
        field.Type = TType.Struct;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        EquipmentWashOpenResponse.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (EquipmentNormalWashResponse != null && __isset.equipmentNormalWashResponse) {
        field.Name = "equipmentNormalWashResponse";
        field.Type = TType.Struct;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        EquipmentNormalWashResponse.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (EquipmentWashUpgradeResponse != null && __isset.equipmentWashUpgradeResponse) {
        field.Name = "equipmentWashUpgradeResponse";
        field.Type = TType.Struct;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        EquipmentWashUpgradeResponse.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (EquipmentBatchWashResponse != null && __isset.equipmentBatchWashResponse) {
        field.Name = "equipmentBatchWashResponse";
        field.Type = TType.Struct;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        EquipmentBatchWashResponse.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (EquipmentCompleteBatchWashResponse != null && __isset.equipmentCompleteBatchWashResponse) {
        field.Name = "equipmentCompleteBatchWashResponse";
        field.Type = TType.Struct;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        EquipmentCompleteBatchWashResponse.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (WashStoneShopResponse != null && __isset.washStoneShopResponse) {
        field.Name = "washStoneShopResponse";
        field.Type = TType.Struct;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        WashStoneShopResponse.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (WashStoneBuyResponse != null && __isset.washStoneBuyResponse) {
        field.Name = "washStoneBuyResponse";
        field.Type = TType.Struct;
        field.ID = 9;
        oprot.WriteFieldBegin(field);
        WashStoneBuyResponse.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (InEquipmentBatchWashResponse != null && __isset.inEquipmentBatchWashResponse) {
        field.Name = "inEquipmentBatchWashResponse";
        field.Type = TType.Struct;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        InEquipmentBatchWashResponse.Write(oprot);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("EquipmentWashResponse(");
      sb.Append("ResType: ");
      sb.Append(ResType);
      sb.Append(",EquipmentWashBaseDataResponse: ");
      sb.Append(EquipmentWashBaseDataResponse== null ? "<null>" : EquipmentWashBaseDataResponse.ToString());
      sb.Append(",EquipmentWashOpenResponse: ");
      sb.Append(EquipmentWashOpenResponse== null ? "<null>" : EquipmentWashOpenResponse.ToString());
      sb.Append(",EquipmentNormalWashResponse: ");
      sb.Append(EquipmentNormalWashResponse== null ? "<null>" : EquipmentNormalWashResponse.ToString());
      sb.Append(",EquipmentWashUpgradeResponse: ");
      sb.Append(EquipmentWashUpgradeResponse== null ? "<null>" : EquipmentWashUpgradeResponse.ToString());
      sb.Append(",EquipmentBatchWashResponse: ");
      sb.Append(EquipmentBatchWashResponse== null ? "<null>" : EquipmentBatchWashResponse.ToString());
      sb.Append(",EquipmentCompleteBatchWashResponse: ");
      sb.Append(EquipmentCompleteBatchWashResponse== null ? "<null>" : EquipmentCompleteBatchWashResponse.ToString());
      sb.Append(",WashStoneShopResponse: ");
      sb.Append(WashStoneShopResponse== null ? "<null>" : WashStoneShopResponse.ToString());
      sb.Append(",WashStoneBuyResponse: ");
      sb.Append(WashStoneBuyResponse== null ? "<null>" : WashStoneBuyResponse.ToString());
      sb.Append(",InEquipmentBatchWashResponse: ");
      sb.Append(InEquipmentBatchWashResponse== null ? "<null>" : InEquipmentBatchWashResponse.ToString());
      sb.Append(")");
      return sb.ToString();
    }

  }

}
