using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ChatSmileyExtraPackListMessage : NetworkMessage
	{
		public const uint Id = 6596;

		public sbyte[] packIds;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6596;
			}
		}

		public ChatSmileyExtraPackListMessage()
		{
		}

		public ChatSmileyExtraPackListMessage(sbyte[] packIds)
		{
			this.packIds = packIds;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = (ushort)reader.ReadVarInt();
			this.packIds = new sbyte[num];
			for (int i = 0; i < num; i++)
			{
				this.packIds[i] = reader.ReadSByte();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)((int)this.packIds.Length));
			sbyte[] numArray = this.packIds;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteSByte(numArray[i]);
			}
		}
	}
}