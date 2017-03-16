using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class AcquaintanceSearchMessage : NetworkMessage
	{
		public const uint Id = 6144;

		public string nickname;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6144;
			}
		}

		public AcquaintanceSearchMessage()
		{
		}

		public AcquaintanceSearchMessage(string nickname)
		{
			this.nickname = nickname;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.nickname = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(this.nickname);
		}
	}
}