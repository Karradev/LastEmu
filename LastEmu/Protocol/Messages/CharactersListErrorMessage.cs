using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class CharactersListErrorMessage : NetworkMessage
	{
		public const uint Id = 5545;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5545;
			}
		}

		public CharactersListErrorMessage()
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