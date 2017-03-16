using System;
using Protocol.IO;

namespace Protocol
{
    public abstract class NetworkMessage
    {
        public abstract uint ProtocolId { get; }

        private static byte ComputeTypeLen(int param1)
        {
            byte num;
            if (param1 > 65535)
                num = 3;
            else if (param1 <= 255)
                num = (byte) (param1 <= 0 ? 0 : 1);
            else
            {
                num = 2;
            }
            return num;
        }

        public abstract void Deserialize(IDataReader reader);

        public void Pack(IDataWriter writer)
        {
            Serialize(writer);
            WritePacket(writer);
        }

        public abstract void Serialize(IDataWriter reader);

        private static uint SubComputeStaticHeader(uint id, byte typeLen) => id << 2 | typeLen;

        public override string ToString() => GetType().Name;

        public void Unpack(IDataReader reader) => Deserialize(reader);

        private void WritePacket(IDataWriter writer)
        {
            var data = writer.Data;
            writer.Clear();
            var num = ComputeTypeLen(data.Length);
            var num1 = SubComputeStaticHeader(ProtocolId, num);
            writer.WriteShort((short) num1);
            switch (num)
            {
                case 0:
                    break;
                case 1:
                    writer.WriteByte((byte) (data.Length));
                    break;
                case 2:
                    writer.WriteShort((short) (data.Length));
                    break;
                case 3:
                    writer.WriteByte((byte) (data.Length >> 16 & 255));
                    writer.WriteShort((short) (data.Length & 65535));
                    break;
                default:
                    throw new Exception("Packet's length can't be encoded on 4 or more bytes");
            }
            writer.WriteBytes(data);
        }
    }
}
