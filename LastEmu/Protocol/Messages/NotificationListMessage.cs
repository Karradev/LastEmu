using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class NotificationListMessage : NetworkMessage
	{
		public const uint Id = 6087;

		public int[] flags;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6087;
			}
		}

		public NotificationListMessage()
		{
		}

		public NotificationListMessage(int[] flags)
		{
			this.flags = flags;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.flags = new int[num];
			for (int i = 0; i < num; i++)
			{
				this.flags[i] = reader.ReadVarInt();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.flags.Length));
			int[] numArray = this.flags;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteVarInt(numArray[i]);
			}
		}
	}
}