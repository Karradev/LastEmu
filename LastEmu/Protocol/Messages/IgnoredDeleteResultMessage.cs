using Protocol.IO;


using System;

namespace Protocol.Messages
{
	public class IgnoredDeleteResultMessage : NetworkMessage
	{
		public const uint Id = 5677;

		public bool success;

		public bool session;

		public string name;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5677;
			}
		}

		public IgnoredDeleteResultMessage()
		{
		}

		public IgnoredDeleteResultMessage(bool success, bool session, string name)
		{
			this.success = success;
			this.session = session;
			this.name = name;
		}

		public override void Deserialize(IDataReader reader)
		{
			byte num = reader.ReadByte();
			this.success = BooleanByteWrapper.GetFlag(num, 0);
			this.session = BooleanByteWrapper.GetFlag(num, 1);
			this.name = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			byte num = BooleanByteWrapper.SetFlag(0, 0, this.success);
			writer.WriteByte(BooleanByteWrapper.SetFlag(num, 1, this.session));
			writer.WriteUTF(this.name);
		}
	}
}