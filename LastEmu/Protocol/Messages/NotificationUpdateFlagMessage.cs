using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class NotificationUpdateFlagMessage : NetworkMessage
	{
		public const uint Id = 6090;

		public uint index;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6090;
			}
		}

		public NotificationUpdateFlagMessage()
		{
		}

		public NotificationUpdateFlagMessage(uint index)
		{
			this.index = index;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.index = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.index);
		}
	}
}