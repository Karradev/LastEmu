using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class AtlasPointInformationsMessage : NetworkMessage
	{
		public const uint Id = 5956;

		public AtlasPointsInformations type;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5956;
			}
		}

		public AtlasPointInformationsMessage()
		{
		}

		public AtlasPointInformationsMessage(AtlasPointsInformations type)
		{
			this.type = type;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.type = new AtlasPointsInformations();
			this.type.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			this.type.Serialize(writer);
		}
	}
}