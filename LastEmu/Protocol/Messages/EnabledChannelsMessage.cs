using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class EnabledChannelsMessage : NetworkMessage
	{
		public const uint Id = 892;

		public sbyte[] channels;

		public sbyte[] disallowed;

		public override uint ProtocolId
		{
			get
			{
				return (uint)892;
			}
		}

		public EnabledChannelsMessage()
		{
		}

		public EnabledChannelsMessage(sbyte[] channels, sbyte[] disallowed)
		{
			this.channels = channels;
			this.disallowed = disallowed;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = (ushort)reader.ReadVarInt();
			this.channels = new sbyte[num];
			for (int i = 0; i < num; i++)
			{
				this.channels[i] = reader.ReadSByte();
			}
			num = (ushort)reader.ReadVarInt();
			this.disallowed = new sbyte[num];
			for (int j = 0; j < num; j++)
			{
				this.disallowed[j] = reader.ReadSByte();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)((int)this.channels.Length));
			sbyte[] numArray = this.channels;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteSByte(numArray[i]);
			}
			writer.WriteVarInt((int)((int)this.disallowed.Length));
			sbyte[] numArray1 = this.disallowed;
			for (int j = 0; j < (int)numArray1.Length; j++)
			{
				writer.WriteSByte(numArray1[j]);
			}
		}
	}
}