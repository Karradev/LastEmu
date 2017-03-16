using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class CloseHavenBagFurnitureSequenceRequestMessage : NetworkMessage
	{
		public const uint Id = 6621;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6621;
			}
		}

		public CloseHavenBagFurnitureSequenceRequestMessage()
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