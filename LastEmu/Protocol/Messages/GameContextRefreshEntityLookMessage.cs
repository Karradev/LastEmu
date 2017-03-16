using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class GameContextRefreshEntityLookMessage : NetworkMessage
	{
		public const uint Id = 5637;

		public double id;

		public EntityLook look;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5637;
			}
		}

		public GameContextRefreshEntityLookMessage()
		{
		}

		public GameContextRefreshEntityLookMessage(double id, EntityLook look)
		{
			this.id = id;
			this.look = look;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.id = reader.ReadDouble();
			this.look = new EntityLook();
			this.look.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(this.id);
			this.look.Serialize(writer);
		}
	}
}