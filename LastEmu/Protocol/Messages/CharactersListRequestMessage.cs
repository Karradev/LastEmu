using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class CharactersListRequestMessage : NetworkMessage
	{
		public const uint Id = 150;

		public override uint ProtocolId
		{
			get
			{
				return (uint)150;
			}
		}

		public CharactersListRequestMessage()
		{
		}

		public override void Deserialize(IDataReader reader)
		{
		}

		public override void Serialize(IDataWriter writer)
		{
		}
	}
}