using Protocol.IO;


using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class PaddockPropertiesMessage : NetworkMessage
	{
		public const uint Id = 5824;

		public PaddockInformations properties;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5824;
			}
		}

		public PaddockPropertiesMessage()
		{
		}

		public PaddockPropertiesMessage(PaddockInformations properties)
		{
			this.properties = properties;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.properties = ProtocolTypeManager.GetInstance<PaddockInformations>(reader.ReadUShort());
			this.properties.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort(this.properties.TypeId);
			this.properties.Serialize(writer);
		}
	}
}