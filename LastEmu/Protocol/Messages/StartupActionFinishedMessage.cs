using Protocol.IO;


using System;

namespace Protocol.Messages
{
	public class StartupActionFinishedMessage : NetworkMessage
	{
		public const uint Id = 1304;

		public bool success;

		public bool automaticAction;

		public int actionId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)1304;
			}
		}

		public StartupActionFinishedMessage()
		{
		}

		public StartupActionFinishedMessage(bool success, bool automaticAction, int actionId)
		{
			this.success = success;
			this.automaticAction = automaticAction;
			this.actionId = actionId;
		}

		public override void Deserialize(IDataReader reader)
		{
			byte num = reader.ReadByte();
			this.success = BooleanByteWrapper.GetFlag(num, 0);
			this.automaticAction = BooleanByteWrapper.GetFlag(num, 1);
			this.actionId = reader.ReadInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			byte num = BooleanByteWrapper.SetFlag(0, 0, this.success);
			writer.WriteByte(BooleanByteWrapper.SetFlag(num, 1, this.automaticAction));
			writer.WriteInt(this.actionId);
		}
	}
}