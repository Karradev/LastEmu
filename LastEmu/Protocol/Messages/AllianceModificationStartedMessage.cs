using Protocol.IO;


using System;

namespace Protocol.Messages
{
	public class AllianceModificationStartedMessage : NetworkMessage
	{
		public const uint Id = 6444;

		public bool canChangeName;

		public bool canChangeTag;

		public bool canChangeEmblem;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6444;
			}
		}

		public AllianceModificationStartedMessage()
		{
		}

		public AllianceModificationStartedMessage(bool canChangeName, bool canChangeTag, bool canChangeEmblem)
		{
			this.canChangeName = canChangeName;
			this.canChangeTag = canChangeTag;
			this.canChangeEmblem = canChangeEmblem;
		}

		public override void Deserialize(IDataReader reader)
		{
			byte num = reader.ReadByte();
			this.canChangeName = BooleanByteWrapper.GetFlag(num, 0);
			this.canChangeTag = BooleanByteWrapper.GetFlag(num, 1);
			this.canChangeEmblem = BooleanByteWrapper.GetFlag(num, 2);
		}

		public override void Serialize(IDataWriter writer)
		{
			byte num = BooleanByteWrapper.SetFlag(0, 0, this.canChangeName);
			num = BooleanByteWrapper.SetFlag(num, 1, this.canChangeTag);
			writer.WriteByte(BooleanByteWrapper.SetFlag(num, 2, this.canChangeEmblem));
		}
	}
}