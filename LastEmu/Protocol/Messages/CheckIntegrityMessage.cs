using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class CheckIntegrityMessage : NetworkMessage
	{
		public const uint Id = 6372;

		public sbyte[] data;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6372;
			}
		}

		public CheckIntegrityMessage()
		{
		}

		public CheckIntegrityMessage(sbyte[] data)
		{
			this.data = data;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = (ushort)reader.ReadVarInt();
			this.data = new sbyte[num];
			for (int i = 0; i < num; i++)
			{
				this.data[i] = reader.ReadSByte();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)((int)this.data.Length));
			sbyte[] numArray = this.data;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteSByte(numArray[i]);
			}
		}
	}
}