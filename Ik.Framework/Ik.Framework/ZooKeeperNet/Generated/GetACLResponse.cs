// File generated by hadoop record compiler. Do not edit.
/**
* Licensed to the Apache Software Foundation (ASF) under one
* or more contributor license agreements.  See the NOTICE file
* distributed with this work for additional information
* regarding copyright ownership.  The ASF licenses this file
* to you under the Apache License, Version 2.0 (the
* "License"); you may not use this file except in compliance
* with the License.  You may obtain a copy of the License at
*
*     http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/

using System;
using System.Linq;
using Org.Apache.Jute;
using Common.Logging;

namespace Org.Apache.Zookeeper.Proto
{
    public class GetACLResponse : IRecord, IComparable
    {
        private static ILog log = LogManager.GetLogger(typeof(GetACLResponse));
        public GetACLResponse()
        {
        }
        public GetACLResponse(
        System.Collections.Generic.IEnumerable<Org.Apache.Zookeeper.Data.ACL> acl
      ,
        Org.Apache.Zookeeper.Data.Stat stat
      )
        {
            Acl = acl;
            Stat = stat;
        }
        public System.Collections.Generic.IEnumerable<Org.Apache.Zookeeper.Data.ACL> Acl { get; set; }
        public Org.Apache.Zookeeper.Data.Stat Stat { get; set; }
        public void Serialize(IOutputArchive a_, String tag)
        {
            a_.StartRecord(this, tag);
            {
                a_.StartVector(Acl, "acl");
                if (Acl != null)
                {
                    foreach (var e1 in Acl)
                    {
                        a_.WriteRecord(e1, "e1");
                    }
                }
                a_.EndVector(Acl, "acl");
            }
            a_.WriteRecord(Stat, "stat");
            a_.EndRecord(this, tag);
        }
        public void Deserialize(IInputArchive a_, String tag)
        {
            a_.StartRecord(tag);
            {
                IIndex vidx1 = a_.StartVector("acl");
                if (vidx1 != null)
                {
                    var tmpLst = new System.Collections.Generic.List<Org.Apache.Zookeeper.Data.ACL>();
                    for (; !vidx1.Done(); vidx1.Incr())
                    {
                        Org.Apache.Zookeeper.Data.ACL e1;
                        e1 = new Org.Apache.Zookeeper.Data.ACL();
                        a_.ReadRecord(e1, "e1");
                        tmpLst.Add(e1);
                    }
                    Acl = tmpLst;
                }
                a_.EndVector("acl");
            }
            Stat = new Org.Apache.Zookeeper.Data.Stat();
            a_.ReadRecord(Stat, "stat");
            a_.EndRecord(tag);
        }
        public override String ToString()
        {
            try
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                using (IkZooKeeperNet.IO.EndianBinaryWriter writer =
                  new IkZooKeeperNet.IO.EndianBinaryWriter(IkZooKeeperNet.IO.EndianBitConverter.Big, ms, System.Text.Encoding.UTF8))
                {
                    BinaryOutputArchive a_ =
                      new BinaryOutputArchive(writer);
                    a_.StartRecord(this, string.Empty);
                    {
                        a_.StartVector(Acl, "acl");
                        if (Acl != null)
                        {
                            foreach (var e1 in Acl)
                            {
                                a_.WriteRecord(e1, "e1");
                            }
                        }
                        a_.EndVector(Acl, "acl");
                    }
                    a_.WriteRecord(Stat, "stat");
                    a_.EndRecord(this, string.Empty);
                    ms.Position = 0;
                    return System.Text.Encoding.UTF8.GetString(ms.ToArray());
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
            return "ERROR";
        }
        public void Write(IkZooKeeperNet.IO.EndianBinaryWriter writer)
        {
            BinaryOutputArchive archive = new BinaryOutputArchive(writer);
            Serialize(archive, string.Empty);
        }
        public void ReadFields(IkZooKeeperNet.IO.EndianBinaryReader reader)
        {
            BinaryInputArchive archive = new BinaryInputArchive(reader);
            Deserialize(archive, string.Empty);
        }
        public int CompareTo(object obj)
        {
            throw new InvalidOperationException("comparing GetACLResponse is unimplemented");
        }
        public override bool Equals(object obj)
        {
            GetACLResponse peer = (GetACLResponse)obj;
            if (peer == null)
            {
                return false;
            }
            if (Object.ReferenceEquals(peer, this))
            {
                return true;
            }
            bool ret = false;
            ret = Acl.Equals(peer.Acl);
            if (!ret) return ret;
            ret = Stat.Equals(peer.Stat);
            if (!ret) return ret;
            return ret;
        }
        public override int GetHashCode()
        {
            int result = 17;
            int ret = GetType().GetHashCode();
            result = 37 * result + ret;
            ret = Acl.GetHashCode();
            result = 37 * result + ret;
            ret = Stat.GetHashCode();
            result = 37 * result + ret;
            return result;
        }
        public static string Signature()
        {
            return "LGetACLResponse([LACL(iLId(ss))]LStat(lllliiiliil))";
        }
    }
}
#region copyright
/*
*.NET基础开发框架
*Copyright (C) 。。。
*地址：git@github.com:gangzaicd/Ik.Framework.git
*作者：到大叔碗里来（大叔）
*QQ：397754531
*eMail：gangzaicd@163.com
*/
#endregion copyright
