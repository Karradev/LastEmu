using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class OpenHavenBagFurnitureSequenceRequestMessage : NetworkMessage
	{
		public const uint Id = 6635;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6635;
			}
		}

		public OpenHavenBagFurnitureSequenceRequestMessage()
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