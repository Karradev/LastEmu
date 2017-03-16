using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class NicknameChoiceRequestMessage : NetworkMessage
	{
		public const uint Id = 5639;

		public string nickname;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5639;
			}
		}

		public NicknameChoiceRequestMessage()
		{
		}

		public NicknameChoiceRequestMessage(string nickname)
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