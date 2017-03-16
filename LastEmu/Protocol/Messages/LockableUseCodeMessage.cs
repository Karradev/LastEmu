using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class LockableUseCodeMessage : NetworkMessage
	{
		public const uint Id = 5667;

		public string code;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5667;
			}
		}

		public LockableUseCodeMessage()
		{
		}

		public LockableUseCodeMessage(string code)
		{
			this.code = code;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.code = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(this.code);
		}
	}
}