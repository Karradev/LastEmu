using Protocol.IO;


using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class HousePropertiesMessage : NetworkMessage
	{
		public const uint Id = 5734;

		public HouseInformations properties;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5734;
			}
		}

		public HousePropertiesMessage()
		{
		}

		public HousePropertiesMessage(HouseInformations properties)
		{
			this.properties = properties;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.properties = ProtocolTypeManager.GetInstance<HouseInformations>(reader.ReadUShort());
			this.properties.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort(this.properties.TypeId);
			this.properties.Serialize(writer);
		}
	}
}