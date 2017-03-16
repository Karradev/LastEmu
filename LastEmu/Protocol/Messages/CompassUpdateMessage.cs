using Protocol.IO;


using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class CompassUpdateMessage : NetworkMessage
	{
		public const uint Id = 5591;

		public sbyte type;

		public MapCoordinates coords;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5591;
			}
		}

		public CompassUpdateMessage()
		{
		}

		public CompassUpdateMessage(sbyte type, MapCoordinates coords)
		{
			this.type = type;
			this.coords = coords;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.type = reader.ReadSByte();
			this.coords = ProtocolTypeManager.GetInstance<MapCoordinates>(reader.ReadUShort());
			this.coords.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.type);
			writer.WriteShort(this.coords.TypeId);
			this.coords.Serialize(writer);
		}
	}
}