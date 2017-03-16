using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class LockableChangeCodeMessage : NetworkMessage
	{
		public const uint Id = 5666;

		public string code;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5666;
			}
		}

		public LockableChangeCodeMessage()
		{
		}

		public LockableChangeCodeMessage(string code)
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