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
    public class SetWatches : IRecord, IComparable
    {
        private static ILog log = LogManager.GetLogger(typeof(SetWatches));
        public SetWatches()
        {
        }
        public SetWatches(
        long relativeZxid
      ,
        System.Collections.Generic.IEnumerable<string> dataWatches
      ,
        System.Collections.Generic.IEnumerable<string> existWatches
      ,
        System.Collections.Generic.IEnumerable<string> childWatches
      )
        {
            RelativeZxid = relativeZxid;
            DataWatches = dataWatches;
            ExistWatches = existWatches;
            ChildWatches = childWatches;
        }
        public long RelativeZxid { get; set; }
        public System.Collections.Generic.IEnumerable<string> DataWatches { get; set; }
        public System.Collections.Generic.IEnumerable<string> ExistWatches { get; set; }
        public System.Collections.Generic.IEnumerable<string> ChildWatches { get; set; }
        public void Serialize(IOutputArchive a_, String tag)
        {
            a_.StartRecord(this, tag);
            a_.WriteLong(RelativeZxid, "relativeZxid");
            {
                a_.StartVector(DataWatches, "dataWatches");
                if (DataWatches != null)
                {
                    foreach (var e1 in DataWatches)
                    {
                        a_.WriteString(e1, e1);
                    }
                }
                a_.EndVector(DataWatches, "dataWatches");
            }
            {
                a_.StartVector(ExistWatches, "existWatches");
                if (ExistWatches != null)
                {
                    foreach (var e1 in ExistWatches)
                    {
                        a_.WriteString(e1, e1);
                    }
                }
                a_.EndVector(ExistWatches, "existWatches");
            }
            {
                a_.StartVector(ChildWatches, "childWatches");
                if (ChildWatches != null)
                {
                    foreach (var e1 in ChildWatches)
                    {
                        a_.WriteString(e1, e1);
                    }
                }
                a_.EndVector(ChildWatches, "childWatches");
            }
            a_.EndRecord(this, tag);
        }
        public void Deserialize(IInputArchive a_, String tag)
        {
            a_.StartRecord(tag);
            RelativeZxid = a_.ReadLong("relativeZxid");
            {
                IIndex vidx1 = a_.StartVector("dataWatches");
                if (vidx1 != null)
                {
                    var tmpLst = new System.Collections.Generic.List<string>();
                    for (; !vidx1.Done(); vidx1.Incr())
                    {
                        String e1;
                        e1 = a_.ReadString("e1");
                        tmpLst.Add(e1);
                    }
                    DataWatches = tmpLst;
                }
                a_.EndVector("dataWatches");
            }
            {
                IIndex vidx1 = a_.StartVector("existWatches");
                if (vidx1 != null)
                {
                    var tmpLst = new System.Collections.Generic.List<string>();
                    for (; !vidx1.Done(); vidx1.Incr())
                    {
                        String e1;
                        e1 = a_.ReadString("e1");
                        tmpLst.Add(e1);
                    }
                    ExistWatches = tmpLst;
                }
                a_.EndVector("existWatches");
            }
            {
                IIndex vidx1 = a_.StartVector("childWatches");
                if (vidx1 != null)
                {
                    var tmpLst = new System.Collections.Generic.List<string>();
                    for (; !vidx1.Done(); vidx1.Incr())
                    {
                        String e1;
                        e1 = a_.ReadString("e1");
                        tmpLst.Add(e1);
                    }
                    ChildWatches = tmpLst;
                }
                a_.EndVector("childWatches");
            }
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
                    a_.WriteLong(RelativeZxid, "relativeZxid");
                    {
                        a_.StartVector(DataWatches, "dataWatches");
                        if (DataWatches != null)
                        {
                            foreach (var e1 in DataWatches)
                            {
                                a_.WriteString(e1, e1);
                            }
                        }
                        a_.EndVector(DataWatches, "dataWatches");
                    }
                    {
                        a_.StartVector(ExistWatches, "existWatches");
                        if (ExistWatches != null)
                        {
                            foreach (var e1 in ExistWatches)
                            {
                                a_.WriteString(e1, e1);
                            }
                        }
                        a_.EndVector(ExistWatches, "existWatches");
                    }
                    {
                        a_.StartVector(ChildWatches, "childWatches");
                        if (ChildWatches != null)
                        {
                            foreach (var e1 in ChildWatches)
                            {
                                a_.WriteString(e1, e1);
                            }
                        }
                        a_.EndVector(ChildWatches, "childWatches");
                    }
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
            throw new InvalidOperationException("comparing SetWatches is unimplemented");
        }
        public override bool Equals(object obj)
        {
            SetWatches peer = (SetWatches)obj;
            if (peer == null)
            {
                return false;
            }
            if (Object.ReferenceEquals(peer, this))
            {
                return true;
            }
            bool ret = false;
            ret = (RelativeZxid == peer.RelativeZxid);
            if (!ret) return ret;
            ret = DataWatches.Equals(peer.DataWatches);
            if (!ret) return ret;
            ret = ExistWatches.Equals(peer.ExistWatches);
            if (!ret) return ret;
            ret = ChildWatches.Equals(peer.ChildWatches);
            if (!ret) return ret;
            return ret;
        }
        public override int GetHashCode()
        {
            int result = 17;
            int ret = GetType().GetHashCode();
            result = 37 * result + ret;
            ret = (int)RelativeZxid;
            result = 37 * result + ret;
            ret = DataWatches.GetHashCode();
            result = 37 * result + ret;
            ret = ExistWatches.GetHashCode();
            result = 37 * result + ret;
            ret = ChildWatches.GetHashCode();
            result = 37 * result + ret;
            return result;
        }
        public static string Signature()
        {
            return "LSetWatches(l[s][s][s])";
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
