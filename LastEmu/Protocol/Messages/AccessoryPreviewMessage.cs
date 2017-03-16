using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class AccessoryPreviewMessage : NetworkMessage
	{
		public const uint Id = 6517;

		public EntityLook look;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6517;
			}
		}

		public AccessoryPreviewMessage()
		{
		}

		public AccessoryPreviewMessage(EntityLook look)
		{
			this.look = look;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.look = new EntityLook();
			this.look.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			this.look.Serialize(writer);
		}
	}
}