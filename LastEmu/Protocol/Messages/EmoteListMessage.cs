using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class EmoteListMessage : NetworkMessage
	{
		public const uint Id = 5689;

		public byte[] emoteIds;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5689;
			}
		}

		public EmoteListMessage()
		{
		}

		public EmoteListMessage(byte[] emoteIds)
		{
			this.emoteIds = emoteIds;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = (ushort)reader.ReadVarInt();
			this.emoteIds = new byte[num];
			for (int i = 0; i < num; i++)
			{
				this.emoteIds[i] = reader.ReadByte();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)((int)this.emoteIds.Length));
			byte[] numArray = this.emoteIds;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteByte(numArray[i]);
			}
		}
	}
}