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

  public partial class FriendRequest : TBase
  {
    private string _idFriendRequest;
    private string _IdToUser;
    private string _IdFromUser;
    private string _DateTimeWhenRequestWasCreated;

    public string IdFriendRequest
    {
      get
      {
        return _idFriendRequest;
      }
      set
      {
        __isset.idFriendRequest = true;
        this._idFriendRequest = value;
      }
    }

    public string IdToUser
    {
      get
      {
        return _IdToUser;
      }
      set
      {
        __isset.IdToUser = true;
        this._IdToUser = value;
      }
    }

    public string IdFromUser
    {
      get
      {
        return _IdFromUser;
      }
      set
      {
        __isset.IdFromUser = true;
        this._IdFromUser = value;
      }
    }

    public string DateTimeWhenRequestWasCreated
    {
      get
      {
        return _DateTimeWhenRequestWasCreated;
      }
      set
      {
        __isset.DateTimeWhenRequestWasCreated = true;
        this._DateTimeWhenRequestWasCreated = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool idFriendRequest;
      public bool IdToUser;
      public bool IdFromUser;
      public bool DateTimeWhenRequestWasCreated;
    }

    public FriendRequest()
    {
    }

    public FriendRequest DeepCopy()
    {
      var tmp20 = new FriendRequest();
      if((IdFriendRequest != null) && __isset.idFriendRequest)
      {
        tmp20.IdFriendRequest = this.IdFriendRequest;
      }
      tmp20.__isset.idFriendRequest = this.__isset.idFriendRequest;
      if((IdToUser != null) && __isset.IdToUser)
      {
        tmp20.IdToUser = this.IdToUser;
      }
      tmp20.__isset.IdToUser = this.__isset.IdToUser;
      if((IdFromUser != null) && __isset.IdFromUser)
      {
        tmp20.IdFromUser = this.IdFromUser;
      }
      tmp20.__isset.IdFromUser = this.__isset.IdFromUser;
      if((DateTimeWhenRequestWasCreated != null) && __isset.DateTimeWhenRequestWasCreated)
      {
        tmp20.DateTimeWhenRequestWasCreated = this.DateTimeWhenRequestWasCreated;
      }
      tmp20.__isset.DateTimeWhenRequestWasCreated = this.__isset.DateTimeWhenRequestWasCreated;
      return tmp20;
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
                IdFriendRequest = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.String)
              {
                IdToUser = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.String)
              {
                IdFromUser = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.String)
              {
                DateTimeWhenRequestWasCreated = await iprot.ReadStringAsync(cancellationToken);
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
        var tmp21 = new TStruct("FriendRequest");
        await oprot.WriteStructBeginAsync(tmp21, cancellationToken);
        var tmp22 = new TField();
        if((IdFriendRequest != null) && __isset.idFriendRequest)
        {
          tmp22.Name = "idFriendRequest";
          tmp22.Type = TType.String;
          tmp22.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp22, cancellationToken);
          await oprot.WriteStringAsync(IdFriendRequest, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((IdToUser != null) && __isset.IdToUser)
        {
          tmp22.Name = "IdToUser";
          tmp22.Type = TType.String;
          tmp22.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp22, cancellationToken);
          await oprot.WriteStringAsync(IdToUser, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((IdFromUser != null) && __isset.IdFromUser)
        {
          tmp22.Name = "IdFromUser";
          tmp22.Type = TType.String;
          tmp22.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp22, cancellationToken);
          await oprot.WriteStringAsync(IdFromUser, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((DateTimeWhenRequestWasCreated != null) && __isset.DateTimeWhenRequestWasCreated)
        {
          tmp22.Name = "DateTimeWhenRequestWasCreated";
          tmp22.Type = TType.String;
          tmp22.ID = 4;
          await oprot.WriteFieldBeginAsync(tmp22, cancellationToken);
          await oprot.WriteStringAsync(DateTimeWhenRequestWasCreated, cancellationToken);
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
      if (!(that is FriendRequest other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.idFriendRequest == other.__isset.idFriendRequest) && ((!__isset.idFriendRequest) || (global::System.Object.Equals(IdFriendRequest, other.IdFriendRequest))))
        && ((__isset.IdToUser == other.__isset.IdToUser) && ((!__isset.IdToUser) || (global::System.Object.Equals(IdToUser, other.IdToUser))))
        && ((__isset.IdFromUser == other.__isset.IdFromUser) && ((!__isset.IdFromUser) || (global::System.Object.Equals(IdFromUser, other.IdFromUser))))
        && ((__isset.DateTimeWhenRequestWasCreated == other.__isset.DateTimeWhenRequestWasCreated) && ((!__isset.DateTimeWhenRequestWasCreated) || (global::System.Object.Equals(DateTimeWhenRequestWasCreated, other.DateTimeWhenRequestWasCreated))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if((IdFriendRequest != null) && __isset.idFriendRequest)
        {
          hashcode = (hashcode * 397) + IdFriendRequest.GetHashCode();
        }
        if((IdToUser != null) && __isset.IdToUser)
        {
          hashcode = (hashcode * 397) + IdToUser.GetHashCode();
        }
        if((IdFromUser != null) && __isset.IdFromUser)
        {
          hashcode = (hashcode * 397) + IdFromUser.GetHashCode();
        }
        if((DateTimeWhenRequestWasCreated != null) && __isset.DateTimeWhenRequestWasCreated)
        {
          hashcode = (hashcode * 397) + DateTimeWhenRequestWasCreated.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp23 = new StringBuilder("FriendRequest(");
      int tmp24 = 0;
      if((IdFriendRequest != null) && __isset.idFriendRequest)
      {
        if(0 < tmp24++) { tmp23.Append(", "); }
        tmp23.Append("IdFriendRequest: ");
        IdFriendRequest.ToString(tmp23);
      }
      if((IdToUser != null) && __isset.IdToUser)
      {
        if(0 < tmp24++) { tmp23.Append(", "); }
        tmp23.Append("IdToUser: ");
        IdToUser.ToString(tmp23);
      }
      if((IdFromUser != null) && __isset.IdFromUser)
      {
        if(0 < tmp24++) { tmp23.Append(", "); }
        tmp23.Append("IdFromUser: ");
        IdFromUser.ToString(tmp23);
      }
      if((DateTimeWhenRequestWasCreated != null) && __isset.DateTimeWhenRequestWasCreated)
      {
        if(0 < tmp24++) { tmp23.Append(", "); }
        tmp23.Append("DateTimeWhenRequestWasCreated: ");
        DateTimeWhenRequestWasCreated.ToString(tmp23);
      }
      tmp23.Append(')');
      return tmp23.ToString();
    }
  }

}
