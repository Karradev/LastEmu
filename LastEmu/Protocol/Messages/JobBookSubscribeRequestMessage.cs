using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class JobBookSubscribeRequestMessage : NetworkMessage
	{
		public const uint Id = 6592;

		public sbyte[] jobIds;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6592;
			}
		}

		public JobBookSubscribeRequestMessage()
		{
		}

		public JobBookSubscribeRequestMessage(sbyte[] jobIds)
		{
			this.jobIds = jobIds;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = (ushort)reader.ReadVarInt();
			this.jobIds = new sbyte[num];
			for (int i = 0; i < num; i++)
			{
				this.jobIds[i] = reader.ReadSByte();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)((int)this.jobIds.Length));
			sbyte[] numArray = this.jobIds;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteSByte(numArray[i]);
			}
		}
	}
}