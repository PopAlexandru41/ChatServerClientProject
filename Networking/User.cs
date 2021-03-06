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

  public partial class User : TBase
  {
    private string _IdUser;
    private string _Name;
    private string _Password;
    private int _NrOfFriendRequests;

    public string IdUser
    {
      get
      {
        return _IdUser;
      }
      set
      {
        __isset.IdUser = true;
        this._IdUser = value;
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

    public string Password
    {
      get
      {
        return _Password;
      }
      set
      {
        __isset.Password = true;
        this._Password = value;
      }
    }

    public int NrOfFriendRequests
    {
      get
      {
        return _NrOfFriendRequests;
      }
      set
      {
        __isset.NrOfFriendRequests = true;
        this._NrOfFriendRequests = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool IdUser;
      public bool Name;
      public bool Password;
      public bool NrOfFriendRequests;
    }

    public User()
    {
    }

    public User DeepCopy()
    {
      var tmp0 = new User();
      if((IdUser != null) && __isset.IdUser)
      {
        tmp0.IdUser = this.IdUser;
      }
      tmp0.__isset.IdUser = this.__isset.IdUser;
      if((Name != null) && __isset.Name)
      {
        tmp0.Name = this.Name;
      }
      tmp0.__isset.Name = this.__isset.Name;
      if((Password != null) && __isset.Password)
      {
        tmp0.Password = this.Password;
      }
      tmp0.__isset.Password = this.__isset.Password;
      if(__isset.NrOfFriendRequests)
      {
        tmp0.NrOfFriendRequests = this.NrOfFriendRequests;
      }
      tmp0.__isset.NrOfFriendRequests = this.__isset.NrOfFriendRequests;
      return tmp0;
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
                IdUser = await iprot.ReadStringAsync(cancellationToken);
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
              if (field.Type == TType.String)
              {
                Password = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.I32)
              {
                NrOfFriendRequests = await iprot.ReadI32Async(cancellationToken);
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
        var tmp1 = new TStruct("User");
        await oprot.WriteStructBeginAsync(tmp1, cancellationToken);
        var tmp2 = new TField();
        if((IdUser != null) && __isset.IdUser)
        {
          tmp2.Name = "IdUser";
          tmp2.Type = TType.String;
          tmp2.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp2, cancellationToken);
          await oprot.WriteStringAsync(IdUser, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Name != null) && __isset.Name)
        {
          tmp2.Name = "Name";
          tmp2.Type = TType.String;
          tmp2.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp2, cancellationToken);
          await oprot.WriteStringAsync(Name, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Password != null) && __isset.Password)
        {
          tmp2.Name = "Password";
          tmp2.Type = TType.String;
          tmp2.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp2, cancellationToken);
          await oprot.WriteStringAsync(Password, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.NrOfFriendRequests)
        {
          tmp2.Name = "NrOfFriendRequests";
          tmp2.Type = TType.I32;
          tmp2.ID = 4;
          await oprot.WriteFieldBeginAsync(tmp2, cancellationToken);
          await oprot.WriteI32Async(NrOfFriendRequests, cancellationToken);
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
      if (!(that is User other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.IdUser == other.__isset.IdUser) && ((!__isset.IdUser) || (global::System.Object.Equals(IdUser, other.IdUser))))
        && ((__isset.Name == other.__isset.Name) && ((!__isset.Name) || (global::System.Object.Equals(Name, other.Name))))
        && ((__isset.Password == other.__isset.Password) && ((!__isset.Password) || (global::System.Object.Equals(Password, other.Password))))
        && ((__isset.NrOfFriendRequests == other.__isset.NrOfFriendRequests) && ((!__isset.NrOfFriendRequests) || (global::System.Object.Equals(NrOfFriendRequests, other.NrOfFriendRequests))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if((IdUser != null) && __isset.IdUser)
        {
          hashcode = (hashcode * 397) + IdUser.GetHashCode();
        }
        if((Name != null) && __isset.Name)
        {
          hashcode = (hashcode * 397) + Name.GetHashCode();
        }
        if((Password != null) && __isset.Password)
        {
          hashcode = (hashcode * 397) + Password.GetHashCode();
        }
        if(__isset.NrOfFriendRequests)
        {
          hashcode = (hashcode * 397) + NrOfFriendRequests.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp3 = new StringBuilder("User(");
      int tmp4 = 0;
      if((IdUser != null) && __isset.IdUser)
      {
        if(0 < tmp4++) { tmp3.Append(", "); }
        tmp3.Append("IdUser: ");
        IdUser.ToString(tmp3);
      }
      if((Name != null) && __isset.Name)
      {
        if(0 < tmp4++) { tmp3.Append(", "); }
        tmp3.Append("Name: ");
        Name.ToString(tmp3);
      }
      if((Password != null) && __isset.Password)
      {
        if(0 < tmp4++) { tmp3.Append(", "); }
        tmp3.Append("Password: ");
        Password.ToString(tmp3);
      }
      if(__isset.NrOfFriendRequests)
      {
        if(0 < tmp4++) { tmp3.Append(", "); }
        tmp3.Append("NrOfFriendRequests: ");
        NrOfFriendRequests.ToString(tmp3);
      }
      tmp3.Append(')');
      return tmp3.ToString();
    }
  }

}
