/**
 * <auto-generated>
 * Autogenerated by Thrift Compiler (0.16.0)
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 * </auto-generated>
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Thrift;
using Thrift.Collections;

using Thrift.Protocol;
using Thrift.Protocol.Entities;
using Thrift.Protocol.Utilities;
using Thrift.Transport;
using Thrift.Transport.Client;
using Thrift.Transport.Server;
using Thrift.Processor;


#nullable disable                // suppress C# 8.0 nullable contexts (we still support earlier versions)
#pragma warning disable IDE0079  // remove unnecessary pragmas
#pragma warning disable IDE1006  // parts of the code use IDL spelling
#pragma warning disable IDE0083  // pattern matching "that is not SomeType" requires net5.0 but we still support earlier versions

namespace ThriftTechChat.Networking
{

  public partial class Chat : TBase
  {
    private string _IdChat;
    private string _Name;
    private bool _IsCreatedDefaul;
    private string _LastMessageDate;

    public string IdChat
    {
      get
      {
        return _IdChat;
      }
      set
      {
        __isset.IdChat = true;
        this._IdChat = value;
      }
    }

    public string Name
    {
      get
      {
        return _Name;
      }
      set
      {
        __isset.Name = true;
        this._Name = value;
      }
    }

    public bool IsCreatedDefaul
    {
      get
      {
        return _IsCreatedDefaul;
      }
      set
      {
        __isset.IsCreatedDefaul = true;
        this._IsCreatedDefaul = value;
      }
    }

    public string LastMessageDate
    {
      get
      {
        return _LastMessageDate;
      }
      set
      {
        __isset.LastMessageDate = true;
        this._LastMessageDate = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool IdChat;
      public bool Name;
      public bool IsCreatedDefaul;
      public bool LastMessageDate;
    }

    public Chat()
    {
    }

    public Chat DeepCopy()
    {
      var tmp10 = new Chat();
      if((IdChat != null) && __isset.IdChat)
      {
        tmp10.IdChat = this.IdChat;
      }
      tmp10.__isset.IdChat = this.__isset.IdChat;
      if((Name != null) && __isset.Name)
      {
        tmp10.Name = this.Name;
      }
      tmp10.__isset.Name = this.__isset.Name;
      if(__isset.IsCreatedDefaul)
      {
        tmp10.IsCreatedDefaul = this.IsCreatedDefaul;
      }
      tmp10.__isset.IsCreatedDefaul = this.__isset.IsCreatedDefaul;
      if((LastMessageDate != null) && __isset.LastMessageDate)
      {
        tmp10.LastMessageDate = this.LastMessageDate;
      }
      tmp10.__isset.LastMessageDate = this.__isset.LastMessageDate;
      return tmp10;
    }

    public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        TField field;
        await iprot.ReadStructBeginAsync(cancellationToken);
        while (true)
        {
          field = await iprot.ReadFieldBeginAsync(cancellationToken);
          if (field.Type == TType.Stop)
          {
            break;
          }

          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.String)
              {
                IdChat = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.String)
              {
                Name = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.Bool)
              {
                IsCreatedDefaul = await iprot.ReadBoolAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.String)
              {
                LastMessageDate = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            default: 
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              break;
          }

          await iprot.ReadFieldEndAsync(cancellationToken);
        }

        await iprot.ReadStructEndAsync(cancellationToken);
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public async global::System.Threading.Tasks.Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
    {
      oprot.IncrementRecursionDepth();
      try
      {
        var tmp11 = new TStruct("Chat");
        await oprot.WriteStructBeginAsync(tmp11, cancellationToken);
        var tmp12 = new TField();
        if((IdChat != null) && __isset.IdChat)
        {
          tmp12.Name = "IdChat";
          tmp12.Type = TType.String;
          tmp12.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp12, cancellationToken);
          await oprot.WriteStringAsync(IdChat, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Name != null) && __isset.Name)
        {
          tmp12.Name = "Name";
          tmp12.Type = TType.String;
          tmp12.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp12, cancellationToken);
          await oprot.WriteStringAsync(Name, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.IsCreatedDefaul)
        {
          tmp12.Name = "IsCreatedDefaul";
          tmp12.Type = TType.Bool;
          tmp12.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp12, cancellationToken);
          await oprot.WriteBoolAsync(IsCreatedDefaul, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((LastMessageDate != null) && __isset.LastMessageDate)
        {
          tmp12.Name = "LastMessageDate";
          tmp12.Type = TType.String;
          tmp12.ID = 4;
          await oprot.WriteFieldBeginAsync(tmp12, cancellationToken);
          await oprot.WriteStringAsync(LastMessageDate, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        await oprot.WriteFieldStopAsync(cancellationToken);
        await oprot.WriteStructEndAsync(cancellationToken);
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override bool Equals(object that)
    {
      if (!(that is Chat other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.IdChat == other.__isset.IdChat) && ((!__isset.IdChat) || (global::System.Object.Equals(IdChat, other.IdChat))))
        && ((__isset.Name == other.__isset.Name) && ((!__isset.Name) || (global::System.Object.Equals(Name, other.Name))))
        && ((__isset.IsCreatedDefaul == other.__isset.IsCreatedDefaul) && ((!__isset.IsCreatedDefaul) || (global::System.Object.Equals(IsCreatedDefaul, other.IsCreatedDefaul))))
        && ((__isset.LastMessageDate == other.__isset.LastMessageDate) && ((!__isset.LastMessageDate) || (global::System.Object.Equals(LastMessageDate, other.LastMessageDate))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if((IdChat != null) && __isset.IdChat)
        {
          hashcode = (hashcode * 397) + IdChat.GetHashCode();
        }
        if((Name != null) && __isset.Name)
        {
          hashcode = (hashcode * 397) + Name.GetHashCode();
        }
        if(__isset.IsCreatedDefaul)
        {
          hashcode = (hashcode * 397) + IsCreatedDefaul.GetHashCode();
        }
        if((LastMessageDate != null) && __isset.LastMessageDate)
        {
          hashcode = (hashcode * 397) + LastMessageDate.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp13 = new StringBuilder("Chat(");
      int tmp14 = 0;
      if((IdChat != null) && __isset.IdChat)
      {
        if(0 < tmp14++) { tmp13.Append(", "); }
        tmp13.Append("IdChat: ");
        IdChat.ToString(tmp13);
      }
      if((Name != null) && __isset.Name)
      {
        if(0 < tmp14++) { tmp13.Append(", "); }
        tmp13.Append("Name: ");
        Name.ToString(tmp13);
      }
      if(__isset.IsCreatedDefaul)
      {
        if(0 < tmp14++) { tmp13.Append(", "); }
        tmp13.Append("IsCreatedDefaul: ");
        IsCreatedDefaul.ToString(tmp13);
      }
      if((LastMessageDate != null) && __isset.LastMessageDate)
      {
        if(0 < tmp14++) { tmp13.Append(", "); }
        tmp13.Append("LastMessageDate: ");
        LastMessageDate.ToString(tmp13);
      }
      tmp13.Append(')');
      return tmp13.ToString();
    }
  }

}
