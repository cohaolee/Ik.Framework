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
    public class WatcherEvent : IRecord, IComparable
    {
        private static ILog log = LogManager.GetLogger(typeof(WatcherEvent));
        public WatcherEvent()
        {
        }
        public WatcherEvent(
        int type
      ,
        int state
      ,
        string path
      )
        {
            Type = type;
            State = state;
            Path = path;
        }
        public int Type { get; set; }
        public int State { get; set; }
        public string Path { get; set; }
        public void Serialize(IOutputArchive a_, String tag)
        {
            a_.StartRecord(this, tag);
            a_.WriteInt(Type, "type");
            a_.WriteInt(State, "state");
            a_.WriteString(Path, "path");
            a_.EndRecord(this, tag);
        }
        public void Deserialize(IInputArchive a_, String tag)
        {
            a_.StartRecord(tag);
            Type = a_.ReadInt("type");
            State = a_.ReadInt("state");
            Path = a_.ReadString("path");
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
                    a_.WriteInt(Type, "type");
                    a_.WriteInt(State, "state");
                    a_.WriteString(Path, "path");
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
            WatcherEvent peer = (WatcherEvent)obj;
            if (peer == null)
            {
                throw new InvalidOperationException("Comparing different types of records.");
            }
            int ret = 0;
            ret = (Type == peer.Type) ? 0 : ((Type < peer.Type) ? -1 : 1);
            if (ret != 0) return ret;
            ret = (State == peer.State) ? 0 : ((State < peer.State) ? -1 : 1);
            if (ret != 0) return ret;
            ret = Path.CompareTo(peer.Path);
            if (ret != 0) return ret;
            return ret;
        }
        public override bool Equals(object obj)
        {
            WatcherEvent peer = (WatcherEvent)obj;
            if (peer == null)
            {
                return false;
            }
            if (Object.ReferenceEquals(peer, this))
            {
                return true;
            }
            bool ret = false;
            ret = (Type == peer.Type);
            if (!ret) return ret;
            ret = (State == peer.State);
            if (!ret) return ret;
            ret = Path.Equals(peer.Path);
            if (!ret) return ret;
            return ret;
        }
        public override int GetHashCode()
        {
            int result = 17;
            int ret = GetType().GetHashCode();
            result = 37 * result + ret;
            ret = (int)Type;
            result = 37 * result + ret;
            ret = (int)State;
            result = 37 * result + ret;
            ret = Path.GetHashCode();
            result = 37 * result + ret;
            return result;
        }
        public static string Signature()
        {
            return "LWatcherEvent(iis)";
        }
    }
}