using Protocol.IO;


using System;

namespace Protocol.Messages
{
	public class GuildModificationStartedMessage : NetworkMessage
	{
		public const uint Id = 6324;

		public bool canChangeName;

		public bool canChangeEmblem;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6324;
			}
		}

		public GuildModificationStartedMessage()
		{
		}

		public GuildModificationStartedMessage(bool canChangeName, bool canChangeEmblem)
		{
			this.canChangeName = canChangeName;
			this.canChangeEmblem = canChangeEmblem;
		}

		public override void Deserialize(IDataReader reader)
		{
			byte num = reader.ReadByte();
			this.canChangeName = BooleanByteWrapper.GetFlag(num, 0);
			this.canChangeEmblem = BooleanByteWrapper.GetFlag(num, 1);
		}

		public override void Serialize(IDataWriter writer)
		{
			byte num = BooleanByteWrapper.SetFlag(0, 0, this.canChangeName);
			writer.WriteByte(BooleanByteWrapper.SetFlag(num, 1, this.canChangeEmblem));
		}
	}
}