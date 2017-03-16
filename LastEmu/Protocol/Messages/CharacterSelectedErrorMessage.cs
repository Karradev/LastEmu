using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class CharacterSelectedErrorMessage : NetworkMessage
	{
		public const uint Id = 5836;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5836;
			}
		}

		public CharacterSelectedErrorMessage()
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